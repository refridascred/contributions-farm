-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, weight, label, owner) VALUES (77, 67.38, 'cached', 'local');
INSERT INTO layout_items (level, weight, label, owner) VALUES (32, 32.73, 'standard', 'blue');
INSERT INTO layout_items (level, weight, label, owner) VALUES (9, 90.44, 'local', 'green');
