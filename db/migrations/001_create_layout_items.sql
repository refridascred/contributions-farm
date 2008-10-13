-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, score, ratio) VALUES (95, 'standard', 81.47, 19.69);
INSERT INTO layout_items (rank, owner, score, ratio) VALUES (92, 'green', 29.2, 66.91);
INSERT INTO layout_items (rank, owner, score, ratio) VALUES (87, 'strict', 36.48, 33.01);
