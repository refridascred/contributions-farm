-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, region) VALUES (44, 33.69, 'strict');
INSERT INTO layout_items (level, score, region) VALUES (49, 71.76, 'blue');
INSERT INTO layout_items (level, score, region) VALUES (87, 23.42, 'standard');
