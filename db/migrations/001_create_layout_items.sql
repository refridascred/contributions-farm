-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, ratio) VALUES ('blue', 19.88, 20.62);
INSERT INTO layout_items (owner, weight, ratio) VALUES ('local', 47.67, 50.26);
INSERT INTO layout_items (owner, weight, ratio) VALUES ('latest', 76.62, 84.44);
