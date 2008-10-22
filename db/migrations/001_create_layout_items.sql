-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, rank, count, ratio) VALUES ('green', 'legacy', 92, 84, 86.23);
INSERT INTO layout_items (region, token, rank, count, ratio) VALUES ('edge', 'standard', 96, 72, 62.41);
INSERT INTO layout_items (region, token, rank, count, ratio) VALUES ('edge', 'legacy', 44, 90, 59.11);
