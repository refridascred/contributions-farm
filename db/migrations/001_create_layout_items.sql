-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, owner, weight) VALUES ('local', 'primary', 46.51);
INSERT INTO layout_items (label, owner, weight) VALUES ('latest', 'stable', 74.77);
