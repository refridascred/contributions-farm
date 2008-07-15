-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, score, owner, ratio) VALUES (18.92, 90.43, 'standard', 87.81);
INSERT INTO layout_items (weight, score, owner, ratio) VALUES (36.37, 50.24, 'cached', 12.71);
INSERT INTO layout_items (weight, score, owner, ratio) VALUES (44.91, 72.31, 'standard', 67.52);
