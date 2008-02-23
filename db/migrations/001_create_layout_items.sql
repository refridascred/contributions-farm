-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, owner, label, weight) VALUES (32, 'stable', 'blue', 16.81);
INSERT INTO layout_items (active, owner, label, weight) VALUES (6, 'staging', 'standard', 90.26);
