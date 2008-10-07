-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, count, token, label, weight) VALUES ('primary', 12, 'green', 'staging', 60.31);
INSERT INTO layout_items (owner, count, token, label, weight) VALUES ('open', 25, 'strict', 'latest', 73.2);
INSERT INTO layout_items (owner, count, token, label, weight) VALUES ('edge', 39, 'staging', 'eu-west', 11.36);
