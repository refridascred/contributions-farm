-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, ratio, label, token) VALUES (84, 39.58, 'latest', 'blue');
INSERT INTO layout_items (level, ratio, label, token) VALUES (82, 67.3, 'cached', 'edge');
