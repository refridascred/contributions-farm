-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, weight) VALUES (84, 'open', 73.89);
INSERT INTO layout_items (rank, label, weight) VALUES (62, 'standard', 97.53);
