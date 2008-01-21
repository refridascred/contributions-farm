-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, rank, region, token) VALUES (21, 93, 'primary', 'stable');
INSERT INTO layout_items (count, rank, region, token) VALUES (37, 93, 'open', 'fallback');
