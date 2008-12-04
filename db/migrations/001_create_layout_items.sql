-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, level, score, weight, label) VALUES ('cached', 93, 79.98, 39.55, 'strict');
INSERT INTO layout_items (region, level, score, weight, label) VALUES ('staging', 15, 37.73, 6.14, 'local');
