-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, region, score) VALUES (61, 'green', 83.77);
INSERT INTO layout_items (count, region, score) VALUES (43, 'staging', 97.57);
INSERT INTO layout_items (count, region, score) VALUES (91, 'standard', 10.76);
