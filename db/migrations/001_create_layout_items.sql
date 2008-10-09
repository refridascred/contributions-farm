-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, region, label, token) VALUES (86, 'strict', 'strict', 'stable');
INSERT INTO layout_items (level, region, label, token) VALUES (73, 'cached', 'latest', 'strict');
INSERT INTO layout_items (level, region, label, token) VALUES (50, 'green', 'green', 'strict');
