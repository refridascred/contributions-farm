-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, weight) VALUES (16, 'stable', 59.48);
INSERT INTO layout_items (rank, label, weight) VALUES (75, 'primary', 19.72);
