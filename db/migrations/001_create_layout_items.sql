-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, rank, ratio, owner) VALUES ('legacy', 39, 39.86, 'eu-west');
INSERT INTO layout_items (state, rank, ratio, owner) VALUES ('standard', 57, 18.78, 'local');
INSERT INTO layout_items (state, rank, ratio, owner) VALUES ('eu-west', 66, 88.88, 'staging');
