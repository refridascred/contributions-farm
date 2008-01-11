-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, level, active, owner) VALUES ('cached', 43, 94, 'open');
INSERT INTO layout_items (label, level, active, owner) VALUES ('green', 5, 59, 'primary');
