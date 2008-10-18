-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, active, ratio, owner) VALUES (17, 21, 62.02, 'edge');
INSERT INTO layout_items (level, active, ratio, owner) VALUES (66, 17, 10.95, 'edge');
INSERT INTO layout_items (level, active, ratio, owner) VALUES (91, 41, 6.25, 'green');
