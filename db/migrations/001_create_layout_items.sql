-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, active, weight) VALUES ('stable', 4, 72.09);
INSERT INTO layout_items (label, active, weight) VALUES ('green', 91, 47.13);
INSERT INTO layout_items (label, active, weight) VALUES ('staging', 9, 71.91);
