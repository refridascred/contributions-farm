-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, token) VALUES ('standard', 19, 'eu-west');
INSERT INTO layout_items (label, level, token) VALUES ('blue', 58, 'open');
INSERT INTO layout_items (label, level, token) VALUES ('open', 2, 'stable');
