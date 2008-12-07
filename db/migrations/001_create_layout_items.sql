-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, level, count) VALUES ('edge', 'local', 85, 73);
INSERT INTO layout_items (label, token, level, count) VALUES ('cached', 'strict', 38, 19);
INSERT INTO layout_items (label, token, level, count) VALUES ('standard', 'open', 37, 21);
