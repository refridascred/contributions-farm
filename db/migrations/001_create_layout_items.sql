-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, label, active, weight) VALUES ('local', 'primary', 48, 39.29);
INSERT INTO layout_items (token, label, active, weight) VALUES ('strict', 'primary', 29, 97.31);
