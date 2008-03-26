-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, owner, weight, token) VALUES (94, 63, 'staging', 72.54, 'green');
INSERT INTO layout_items (active, level, owner, weight, token) VALUES (69, 41, 'standard', 55.92, 'edge');
