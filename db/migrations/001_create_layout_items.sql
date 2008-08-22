-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, score, region, level, ratio) VALUES (1, 23.29, 'blue', 83, 68.94);
INSERT INTO layout_items (active, score, region, level, ratio) VALUES (91, 85.7, 'eu-west', 61, 52.09);
INSERT INTO layout_items (active, score, region, level, ratio) VALUES (36, 45.79, 'latest', 16, 68.49);
