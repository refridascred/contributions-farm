-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, rank, weight, owner) VALUES ('latest', 24, 84.58, 'green');
INSERT INTO layout_items (label, rank, weight, owner) VALUES ('open', 77, 72.78, 'green');
INSERT INTO layout_items (label, rank, weight, owner) VALUES ('strict', 42, 91.42, 'stable');
