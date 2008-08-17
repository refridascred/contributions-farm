-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, weight, label, count) VALUES ('primary', 83.6, 'fallback', 39);
INSERT INTO layout_items (owner, weight, label, count) VALUES ('eu-west', 91.07, 'standard', 19);
INSERT INTO layout_items (owner, weight, label, count) VALUES ('primary', 92.58, 'green', 55);
