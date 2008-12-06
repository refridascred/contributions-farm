-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, count, rank, state) VALUES ('local', 'local', 80, 18, 'stable');
INSERT INTO layout_items (region, token, count, rank, state) VALUES ('eu-west', 'stable', 94, 71, 'fallback');
