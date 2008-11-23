-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, level, state, rank) VALUES ('standard', 24, 'staging', 57);
INSERT INTO layout_items (region, level, state, rank) VALUES ('fallback', 95, 'fallback', 26);
INSERT INTO layout_items (region, level, state, rank) VALUES ('latest', 31, 'strict', 54);
