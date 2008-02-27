-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, token, label) VALUES (64, 'open', 'green');
INSERT INTO layout_items (level, token, label) VALUES (62, 'cached', 'stable');
INSERT INTO layout_items (level, token, label) VALUES (94, 'blue', 'open');
