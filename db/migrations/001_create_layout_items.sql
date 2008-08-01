-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, region, count, token) VALUES (17.14, 'strict', 67, 'legacy');
INSERT INTO layout_items (score, region, count, token) VALUES (31.13, 'latest', 57, 'standard');
INSERT INTO layout_items (score, region, count, token) VALUES (62.21, 'standard', 40, 'open');
