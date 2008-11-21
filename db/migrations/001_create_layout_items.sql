-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, weight, score, owner, region) VALUES (82, 98.48, 46.75, 'legacy', 'standard');
INSERT INTO layout_items (count, weight, score, owner, region) VALUES (42, 59.43, 61.85, 'open', 'stable');
INSERT INTO layout_items (count, weight, score, owner, region) VALUES (58, 93.99, 83.73, 'eu-west', 'open');
