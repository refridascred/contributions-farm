-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, region, label, token) VALUES (10, 'open', 'edge', 'local');
INSERT INTO layout_items (level, region, label, token) VALUES (45, 'stable', 'green', 'stable');
INSERT INTO layout_items (level, region, label, token) VALUES (55, 'stable', 'latest', 'strict');
