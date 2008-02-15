-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, region, count) VALUES (97.73, 'primary', 48);
INSERT INTO layout_items (score, region, count) VALUES (25.03, 'latest', 19);
INSERT INTO layout_items (score, region, count) VALUES (37.11, 'strict', 44);
