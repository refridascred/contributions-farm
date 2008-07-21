-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, level, label, active, token) VALUES (94.84, 55, 'latest', 58, 'latest');
INSERT INTO layout_items (ratio, level, label, active, token) VALUES (58.3, 3, 'green', 83, 'edge');
