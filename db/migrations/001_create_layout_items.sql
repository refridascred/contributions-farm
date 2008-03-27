-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, rank, weight) VALUES ('primary', 90, 33.29);
INSERT INTO layout_items (state, rank, weight) VALUES ('eu-west', 30, 33.95);
