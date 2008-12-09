-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, score, owner) VALUES (37, 88.36, 'local');
INSERT INTO layout_items (active, score, owner) VALUES (89, 84.41, 'stable');
INSERT INTO layout_items (active, score, owner) VALUES (84, 83.99, 'standard');
