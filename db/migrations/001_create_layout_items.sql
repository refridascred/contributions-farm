-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, level) VALUES ('strict', 'local', 17);
INSERT INTO layout_items (label, token, level) VALUES ('legacy', 'primary', 30);
INSERT INTO layout_items (label, token, level) VALUES ('standard', 'green', 73);
