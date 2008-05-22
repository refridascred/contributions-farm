-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, token, weight) VALUES ('staging', 'latest', 82.91);
INSERT INTO layout_items (label, token, weight) VALUES ('legacy', 'fallback', 68.19);
INSERT INTO layout_items (label, token, weight) VALUES ('staging', 'staging', 92.63);
