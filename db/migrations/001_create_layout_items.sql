-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, token, ratio, region) VALUES ('staging', 78, 'fallback', 55.62, 'staging');
INSERT INTO layout_items (label, level, token, ratio, region) VALUES ('fallback', 28, 'cached', 9.77, 'latest');
INSERT INTO layout_items (label, level, token, ratio, region) VALUES ('fallback', 41, 'staging', 19.8, 'cached');
