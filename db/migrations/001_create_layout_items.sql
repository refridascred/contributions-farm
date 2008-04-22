-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, ratio, owner) VALUES (73, 8.38, 'local');
INSERT INTO layout_items (active, ratio, owner) VALUES (71, 18.94, 'primary');
INSERT INTO layout_items (active, ratio, owner) VALUES (22, 46.34, 'stable');
