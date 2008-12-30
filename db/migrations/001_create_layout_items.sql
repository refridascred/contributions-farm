-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, count, token, level) VALUES ('blue', 64, 'primary', 58);
INSERT INTO layout_items (label, count, token, level) VALUES ('local', 39, 'primary', 94);
INSERT INTO layout_items (label, count, token, level) VALUES ('cached', 17, 'blue', 76);
