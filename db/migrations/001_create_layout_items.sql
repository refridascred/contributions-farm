-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, region, ratio, token) VALUES ('local', 47, 'open', 7.0, 'primary');
INSERT INTO layout_items (label, level, region, ratio, token) VALUES ('fallback', 48, 'primary', 47.86, 'latest');
INSERT INTO layout_items (label, level, region, ratio, token) VALUES ('primary', 82, 'open', 76.56, 'legacy');
