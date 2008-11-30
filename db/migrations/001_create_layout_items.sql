-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, weight, owner, score) VALUES (81.2, 'open', 58.25, 'cached', 64.43);
INSERT INTO layout_items (ratio, state, weight, owner, score) VALUES (39.64, 'legacy', 72.41, 'standard', 40.07);
