-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, count, active, owner) VALUES ('open', 86, 92, 'stable');
INSERT INTO layout_items (label, count, active, owner) VALUES ('strict', 93, 46, 'edge');
INSERT INTO layout_items (label, count, active, owner) VALUES ('standard', 35, 34, 'stable');
