-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, level, ratio, label) VALUES (96, 77, 69.45, 'open');
INSERT INTO layout_items (active, level, ratio, label) VALUES (26, 62, 40.14, 'legacy');
INSERT INTO layout_items (active, level, ratio, label) VALUES (66, 73, 84.36, 'eu-west');
