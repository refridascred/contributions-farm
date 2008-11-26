-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, count, token) VALUES (7, 'standard', 46, 'strict');
INSERT INTO layout_items (rank, region, count, token) VALUES (37, 'primary', 2, 'fallback');
INSERT INTO layout_items (rank, region, count, token) VALUES (12, 'green', 63, 'legacy');
