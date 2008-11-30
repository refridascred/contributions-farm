-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, token, score, region, level) VALUES (96.96, 'green', 18.71, 'staging', 96);
INSERT INTO layout_items (ratio, token, score, region, level) VALUES (65.67, 'standard', 15.7, 'standard', 87);
