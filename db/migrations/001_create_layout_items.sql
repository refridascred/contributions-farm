-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label, weight) VALUES (43, 'latest', 12.36);
INSERT INTO layout_items (active, label, weight) VALUES (55, 'local', 38.26);
INSERT INTO layout_items (active, label, weight) VALUES (66, 'latest', 0.54);
