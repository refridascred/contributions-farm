-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, active, level, label, count) VALUES ('stable', 62, 19, 'strict', 2);
INSERT INTO layout_items (token, active, level, label, count) VALUES ('strict', 2, 84, 'green', 43);
INSERT INTO layout_items (token, active, level, label, count) VALUES ('standard', 44, 87, 'strict', 95);
