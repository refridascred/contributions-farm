-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, label, level, ratio, token) VALUES ('eu-west', 'cached', 74, 24.58, 'open');
INSERT INTO layout_items (region, label, level, ratio, token) VALUES ('edge', 'standard', 8, 82.95, 'strict');
