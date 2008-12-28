-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, active, rank, label) VALUES (98.95, 44, 69, 'open');
INSERT INTO layout_items (weight, active, rank, label) VALUES (92.88, 54, 7, 'legacy');
INSERT INTO layout_items (weight, active, rank, label) VALUES (42.37, 11, 45, 'strict');
