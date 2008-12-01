-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, token, weight) VALUES ('local', 2, 'eu-west', 27.52);
INSERT INTO layout_items (label, rank, token, weight) VALUES ('open', 93, 'legacy', 13.58);
