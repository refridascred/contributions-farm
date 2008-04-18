-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, region, score, level) VALUES (61.97, 60.42, 'blue', 48.58, 61);
INSERT INTO layout_items (ratio, weight, region, score, level) VALUES (97.71, 24.81, 'eu-west', 46.41, 42);
INSERT INTO layout_items (ratio, weight, region, score, level) VALUES (47.94, 8.39, 'staging', 81.91, 2);
