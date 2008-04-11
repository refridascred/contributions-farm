-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, region, token, score, level) VALUES (34, 'eu-west', 'blue', 20.19, 66);
INSERT INTO layout_items (count, region, token, score, level) VALUES (16, 'cached', 'open', 56.64, 31);
INSERT INTO layout_items (count, region, token, score, level) VALUES (88, 'legacy', 'eu-west', 24.32, 54);
