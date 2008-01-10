-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, weight, ratio, owner, rank) VALUES ('eu-west', 73.36, 11.49, 'staging', 48);
INSERT INTO layout_items (state, weight, ratio, owner, rank) VALUES ('legacy', 68.79, 34.68, 'blue', 85);
