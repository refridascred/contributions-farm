-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, weight, active, owner) VALUES ('cached', 48.5, 76, 'green');
INSERT INTO layout_items (label, weight, active, owner) VALUES ('primary', 80.82, 91, 'edge');
