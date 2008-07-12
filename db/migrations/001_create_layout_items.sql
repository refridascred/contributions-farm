-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, owner, weight) VALUES ('staging', 'edge', 58.63);
INSERT INTO layout_items (token, owner, weight) VALUES ('legacy', 'strict', 46.78);
INSERT INTO layout_items (token, owner, weight) VALUES ('standard', 'primary', 64.22);
