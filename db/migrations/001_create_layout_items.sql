-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, level, token, weight, owner) VALUES (97, 46, 'blue', 20.78, 'local');
INSERT INTO layout_items (active, level, token, weight, owner) VALUES (19, 73, 'fallback', 89.98, 'staging');
