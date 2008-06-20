-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, label, token, weight) VALUES ('blue', 'edge', 'green', 32.95);
INSERT INTO layout_items (owner, label, token, weight) VALUES ('strict', 'staging', 'edge', 68.47);
INSERT INTO layout_items (owner, label, token, weight) VALUES ('strict', 'blue', 'eu-west', 17.89);
