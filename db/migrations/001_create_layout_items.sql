-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, owner, active) VALUES ('open', 16.49, 'green', 58);
INSERT INTO layout_items (label, weight, owner, active) VALUES ('eu-west', 69.78, 'latest', 87);
