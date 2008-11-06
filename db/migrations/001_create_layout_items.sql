-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, token, weight, active, label) VALUES (15, 'blue', 92.67, 30, 'standard');
INSERT INTO layout_items (level, token, weight, active, label) VALUES (4, 'edge', 36.58, 74, 'strict');
