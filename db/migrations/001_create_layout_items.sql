-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, rank, label, active) VALUES (61.09, 93, 'eu-west', 33);
INSERT INTO layout_items (weight, rank, label, active) VALUES (69.71, 78, 'stable', 90);
