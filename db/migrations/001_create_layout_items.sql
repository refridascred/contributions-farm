-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, ratio, token, owner) VALUES (94, 86, 55.08, 'local', 'eu-west');
INSERT INTO layout_items (active, level, ratio, token, owner) VALUES (68, 57, 14.32, 'strict', 'staging');
INSERT INTO layout_items (active, level, ratio, token, owner) VALUES (94, 69, 1.64, 'standard', 'blue');
