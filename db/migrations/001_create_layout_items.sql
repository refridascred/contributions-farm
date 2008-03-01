-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, ratio, level, token) VALUES (21, 45.76, 36, 'green');
INSERT INTO layout_items (active, ratio, level, token) VALUES (11, 62.09, 36, 'legacy');
INSERT INTO layout_items (active, ratio, level, token) VALUES (44, 94.2, 78, 'standard');
